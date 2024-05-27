namespace Lagersystem
{
    internal class Commands
    {
        private App app;

        public Commands(App app)
        {
            this.app = app;
        }

        public void checkInput(string actionType, string category, string item, int price)
        {
            if (actionType == "add") addProduct(category, item, price);
            if (actionType == "delete") deleteProduct(item);
        }

        private void addProduct(string category, string item, int price)
        {
            if (category == "klær") app.products.Add(new Clothes(item, price));
            else if (category == "elektronikk") app.products.Add(new Electronics(item, price));
            else if (category == "mat") app.products.Add(new Foods(item, price));
        }

        private void deleteProduct(string input)
        {
            app.products.RemoveAll(p => p.Name == input);
        }
    }
}