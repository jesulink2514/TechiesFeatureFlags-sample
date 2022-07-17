using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using TechiesFeatures.Models;

namespace TechiesFeatures.Controllers
{
    public class BetaController : Controller
    {
        [FeatureGate(TechiesFeatureFlags.Beta)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
