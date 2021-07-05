using DiamondPricePrediction.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondPricePrediction.Util
{
    public class DiamondCBR
    {
        private Diamond diamond;
        private Collection<Diamond> diamonds;

        public DiamondCBR(Diamond diamond , Collection<Diamond> diamonds)
        {
            this.diamond = diamond;
            this.diamonds = diamonds;
        }



        public double Result(out Diamond diamond , out Diamond sim)
        {
          
            (double similarity , Diamond diamond) max = (-1 ,new Diamond());
            foreach (var item in diamonds)
            {
              var  _max= DiamondExtenssion.TotalWeight*(
                    DiamondExtenssion.XWeight*( (100- (Math.Abs(this.diamond.X- item.X)/(DiamondExtenssion.XAbsolute))).ToPercent() ) + 
                    DiamondExtenssion.YWeight* ((100 - ( Math.Abs(this.diamond.Y - item.Y) / (DiamondExtenssion.YAbsolute))).ToPercent()) + 
                    DiamondExtenssion.ZWeight* ((100 - (Math.Abs(this.diamond.Z - item.Z) / (DiamondExtenssion.ZAbsolute) )).ToPercent()) + 
                    DiamondExtenssion.CutWeight* ((100 - (Math.Abs(this.diamond.CutValue - item.CutValue) / (DiamondExtenssion.CutAbsolute))).ToPercent()) + 
                    DiamondExtenssion.ColorWeight * ((100 - (Math.Abs(this.diamond.ColorValue - item.ColorValue) / (DiamondExtenssion.ColorAbsolute))).ToPercent()) + 
                    DiamondExtenssion.CaratWeight * ((100 -( Math.Abs(this.diamond.Carat - item.Carat) / (DiamondExtenssion.CaratAbsolute))).ToPercent()) + 
                    DiamondExtenssion.ClarityWeight * ((100 - (Math.Abs(this.diamond.ClarityValue - item.ClarityValue) / (DiamondExtenssion.ClarityAbsolute))).ToPercent()) + 
                    DiamondExtenssion.DepthWeight * ((100 - (Math.Abs(this.diamond.Depth - item.Depth) / (DiamondExtenssion.DepthAbsolute))).ToPercent()) + 
                    DiamondExtenssion.TableWeight * ((100 - (Math.Abs(this.diamond.Table - item.Table) / (DiamondExtenssion.TableAbsolute))).ToPercent()) 
                   // DiamondExtenssion.PriceWeight * ((100 - Math.Abs((float)diamond.Price - (float)item.Price) / (DiamondExtenssion.PriceAbsolute)).ToPercent())
                    );

                max = max.GetMax(_max, item);
            }

            this.diamond.Price = max.diamond.Price;
            diamond = this.diamond;
            sim = max.diamond;

            return max.similarity;
        }


    }
}
