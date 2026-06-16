using Portfolio.Models;

namespace Portfolio.ViewModels
{

    //Tüm tablolardan verileri aynı anda view'ya göndermek için bu kapsayıcı sınıftır.
    public class HomeViewModel
    {
        public List<education> education{set;get;}
        public aboutMe about { get; set; }

        public List<project> projects { get; set; }

        public List<skills> skill { get; set; }
    }
}
