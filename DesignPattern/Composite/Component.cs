namespace Composite
{
    public abstract class Component
    {
        public string Name { get; }

        public Component(string name)
        {
            Name = name;
        }

        //添加子节点
        public abstract void Add(Component c);

        //删除子节点
        public abstract void Remove(Component c);

        //展示方法，dept为节点深度
        public abstract void Display(int depth);
    }
}
