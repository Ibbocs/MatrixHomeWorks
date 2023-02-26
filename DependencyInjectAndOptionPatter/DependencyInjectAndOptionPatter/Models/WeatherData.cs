namespace DependencyInjectAndOptionPatter.Models
{
    public class WeatherData
    {
        public int temperature { get; set; }
        public string city { get; set; }

        private string exMessage = null;
        public string MyException
        {
            get { return exMessage ?? "All Things Are Good"; }
            set { exMessage = value; }
        }

    }
}
