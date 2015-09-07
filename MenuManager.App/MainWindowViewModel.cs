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
                Name = "Item 1",
                ParentItem = menu
            };

            var sub2 = new JsonMenuItem()
            {
                Name = "Item 2",
                ParentItem = menu
            };

            var subsub1 = new JsonMenuItem
            {
                Name = "Test 3",
                ParentItem = sub1
            };

            var subsubsub1 = new JsonMenuItem
            {
                Name = "Test 4",
                ParentItem = subsub1
            };

            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 1", ParentItem = subsubsub1 });
            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 2", ParentItem = subsubsub1 });
            subsubsub1.Items.Add(new JsonMenuItem { Name = "Test 3", ParentItem = subsubsub1 });

            subsub1.Items.Add(new JsonMenuItem { Name = "Test 1", ParentItem = subsub1 });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 2", ParentItem = subsub1 });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 3", ParentItem = subsub1 });
            subsub1.Items.Add(subsubsub1);
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 5", ParentItem = subsub1 });
            subsub1.Items.Add(new JsonMenuItem { Name = "Test 6", ParentItem = subsub1 });


            sub1.Items.Add(new JsonMenuItem { Name = "Test 1", ParentItem = sub1 });
            sub1.Items.Add(new JsonMenuItem { Name = "Test 2", ParentItem = sub1 });
            sub1.Items.Add(subsub1);

            sub2.Items.Add(new JsonMenuItem { Name = "Test 1", ParentItem = sub2 });
            sub2.Items.Add(new JsonMenuItem { Name = "Test 2", ParentItem = sub2 });

            menu.Items.Add(sub1);
            menu.Items.Add(sub2);

            MainMenu = new JsonMenuItem();
            menu.ParentItem = MainMenu;
            MainMenu.Items.Add(menu);
        }
    }
}
