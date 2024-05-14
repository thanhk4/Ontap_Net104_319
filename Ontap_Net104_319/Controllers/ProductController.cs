using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ontap_Net104_319.Models;

namespace Ontap_Net104_319.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _db;
        public ProductController()
        {
            _db = new AppDbContext();
        }

        // GET: ProductController
        public ActionResult Index()
        {
            var jss = _db.products.ToList();
            return View(jss);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(Guid id)
        {
            var jjs = _db.products.Find(id);
            return View(jjs);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        
        public ActionResult Create(Product product)
        {
            try
            {
                _db.products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
              return BadRequest();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var jjs = _db.products.Find(id);
            return View(jjs);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        
        public ActionResult Edit(Product product)
        {
            try
            {
               var sf = _db.products.Find(product.Id);
                sf.Name = product.Name;
                sf.Description = product.Description;
                sf.Price = product.Price;
                sf.Amount = product.Amount;
                _db.Update(sf);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var kss = _db.products.Find(id);
            _db.products.Remove(kss);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddTocart(Guid id, int Quantity)
        {
            // kiểm tra dữ liệu đăng nhập
            var check = HttpContext.Session.GetString("username");
            if (string.IsNullOrEmpty(check))
            {
                return RedirectToAction("Login", "Account");

            }
            else
            {
                // kiểm tra tài khoản trong giỏ hàng đã có trong giỏ hàng chưa
                var cartItem = _db.cartDetails.FirstOrDefault(p=> p.ProductId == id && p.Usename == check);

                if (cartItem == null) // nếu giỏ hàng không có gì
                {
                    CartDetail cartDetail = new CartDetail()
                    { 
                        Id = Guid.NewGuid(), 
                        ProductId = id,
                        Quantity = Quantity,
                        Status = 1,
                        Usename = check
                    };
                    _db.cartDetails.Add(cartDetail);
                    _db.SaveChanges();
                }
                else // nếu có rồi thì cộng dồn
                {
                    cartItem.Quantity = cartItem.Quantity + Quantity;
                    _db.cartDetails.Update(cartItem);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index","Product");
            }
        }
        }
    }

