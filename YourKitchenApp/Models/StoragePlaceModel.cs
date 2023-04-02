
using System;

namespace YourKitchenApp.Models
{
   public class StorageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FridgeTemplate { get; set; }
        public DataTemplate CupboardTemplate { get; set; }
        public DataTemplate OtherTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Ingredient ingredient && ingredient.StoragePlace == "Fridge")
            {
                return FridgeTemplate;
            }

            return OtherTemplate;





        }
    }

}
