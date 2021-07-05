using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DiamondPricePrediction.Model
{
    public class Diamond
    {
        //public static int No { get; private set; }
        public Guid Key => Guid.NewGuid();
        //public Diamond()
        //{
        //  // Task.Factory.StartNew(()=> Console.WriteLine(Key));
        //}

        [Range(minimum:0,maximum:10.74,ErrorMessage ="please enter between 0-10.74")]
        public float X { get; set; }
    

        [Range(minimum: 0, maximum: 58.9, ErrorMessage = "please enter between 0-10.74")]
        public float Y { get; set; }
     


        [Range(minimum: 0, maximum: 31.8, ErrorMessage = "please enter between 0-10.74")]
        public float Z { get; set; }
    



        [Required(ErrorMessage ="Please enter value")]
        public string Cut { get; set; } = "Fair";
        public int CutValue => Cut switch {
            "Fair"=>0,
            "Good" => 1,
            "Very Good" => 2,
            "Premium" => 3,
            "Ideal" => 4,
            _ => 0
        };


        [Required(ErrorMessage = "Please enter value")]
        public string Color { get; set; } = "D";
        public int ColorValue => Color switch
        {
            "J" => 0,
            "I" => 1,
            "H" => 2,
            "G" => 3,
            "F" => 4,
            "E" => 5,
            "D" => 6,
            _ => 0
        };


        [Range(minimum: 0.2, maximum: 5.01, ErrorMessage = "please enter between 0.2-5.01")]
        public float Carat { get; set; }
       



        [Required(ErrorMessage = "Please enter value")]
        public string Clarity { get; set; } = "IF";
        public int ClarityValue => Clarity switch
        {
            "I1" => 0,
            "SI2" => 1,
            "SI1" => 2,
            "VS2" => 3,
            "VS1" => 4,
            "VVS2" => 5,
            "VVS1" => 6,
            "IF" => 7,
            _ => 0
        };

         


        [Range(minimum: 43, maximum: 79, ErrorMessage = "please enter between 43-79")]
        public float Depth { get; set; }
      



        [Range(minimum: 43, maximum: 95, ErrorMessage = "please enter between 43-95")]
        public float Table { get; set; }
       



        [Range(minimum:326, maximum: 18823, ErrorMessage = "please enter between 326$-18,823$")]
        public double? Price { get; set; }


        /// <summary>
        /// ShallowCopy
        /// </summary>
        /// <returns></returns>
        public Diamond Clone()
        {
            return (Diamond)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return  $"{nameof(Key)}:{Key} \n {nameof(X)}:{X} \n {nameof(Y)}:{Y} \n {nameof(Z)}:{Z} \n {nameof(Cut)}:{Cut} \n {nameof(Color)}:{Color} \n {nameof(Carat)}:{Carat} \n {nameof(Clarity)}:{Clarity} \n {nameof(Depth)}:{Depth} \n {nameof(Table)}:{Table} \n {nameof(Price)}:{Price}";
        }
    }
}
