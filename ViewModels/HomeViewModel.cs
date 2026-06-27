using Portfolio.Models;
using PortfolioShared.Models;

namespace Portfolio.ViewModels
{

    //Tüm tablolardan verileri aynı anda view'ya göndermek için bu kapsayıcı sınıftır.
    public class HomeViewModel
    {
        public List<Education> education{set;get;}
        public AboutMe about { get; set; }

        public List<Project> projects { get; set; }

        public List<Skills> skill { get; set; }
    }
}
