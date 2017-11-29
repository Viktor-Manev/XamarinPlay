using System;
using System.Collections.Generic;
using System.Text;

namespace XamainPlayStd.Model
{
    public  class BaseViewModel
    {
        public BaseViewModel()
        {
            relative = new Relatives();
            themes = new Themes();
            lastName = "Butel";
        }

        public string lastName { get; set; }

        public string MiddleName  => "Vice";

        public Relatives relative { get; set; }

        public Themes themes { get; set; }
    }

    public class Themes
    { 
        public string Poteklo => "Dren";
    }

    public class Relatives
    {
        public string Reon => "Green";
    }


    public class MainViewModel : BaseViewModel
    {
        public string FullName { get; set; }
    }
}
