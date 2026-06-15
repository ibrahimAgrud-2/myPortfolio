namespace Portfolio.Models
{
    public class education
    {

        //EF'nin property'leri görebilmesi için public olmalı
        public int Id { get; set; }
        public string schoolTitle { set; get; }
        public string schoolType { set; get; }
        public DateTime entranceYear { set; get; }
        public DateTime endYear { set; get; }
        public string imgPath { set; get; }

    }
}
