namespace module_07
{
    public class Item<T> : Item
    {

    }

    public class Item
    {
        public static int InstanceCount;

        public Item()
        {
            InstanceCount += 1;
        }
    }
}
