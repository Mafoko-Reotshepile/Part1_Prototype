using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ClaimController : Controller
    {
        // Submit new claim
        [HttpPost]
        public IActionResult SubmitClaim(string Month, int HoursWorked, decimal HourlyRate)
        {
            ViewBag.Message = $"Claim submitted for {Month}: {HoursWorked} hours at R{HourlyRate}/hr.";
            return View("../Home/Dashboard"); // reload dashboard
        }

        // Show claim details
        [HttpGet] 
        public IActionResult ClaimDetails(string ClaimID)
        {
            ViewBag.Message = $"Showing details for the Claim {ClaimID} (mock data).";
            return View("../Home/Dashboard");
        }

        // Claim approval
        [HttpPost]
        public IActionResult ClaimProcess(string ClaimID, string Decision, string Comments)
        {
            ViewBag.Message = $"Claim {ClaimID} has been {Decision}. Comments: {Comments}";
            return View("../Home/Dashboard");
        }

        // Upload supporting documents
        [HttpPost]
        public IActionResult UploadDocuments(string ClaimID)
        {
            ViewBag.Message = $"Document uploaded for Claim {ClaimID} (mockup).";
            return View("../Home/Dashboard");
        }
    }
}
