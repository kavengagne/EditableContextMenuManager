using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;


namespace MenuManager.App
{
    public class MainWindowViewModel : ViewModelBase
    {
        public JsonMenuItem MainMenu { get; set; }


        public MainWindowViewModel()
        {
            var menu = new JsonMenuItem
            {
                Name = "Kaven",
            };

            var sub1 = new JsonMenuItem()
            {
                Name = "Item 1"
            };

            var sub2 = new JsonMenuItem()
            {
                Name = "Item 2"
            };

            var subsub1 = new JsonMenuItem
            {
                Name = "Test 3"
            };

            var subsubsub1 = new JsonMenuItem
            {
                Name = "Test 4"
            };

            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 1" });
            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 2" });
            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 3" });

            subsub1.Items.Add(new JsonMenuItem { Name = "Test 1" });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 2" });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 3" });
            subsub1.Items.Add(subsubsub1);
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 5" });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 6" });


            sub1.Items.Add(new JsonMenuItem { Name = "Test 1" });
            sub1.Items.Add(new JsonMenuItem { Name = "Test 2" });
            sub1.Items.Add(subsub1);

            sub2.Items.Add(new JsonMenuItem { Name = "Test 1" });
            sub2.Items.Add(new JsonMenuItem { Name = "Test 2" });

            menu.Items.Add(sub1);
            menu.Items.Add(sub2);

            MainMenu = new JsonMenuItem();
            MainMenu.Items.Add(menu);
        }
    }
}
