namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void SetFlyBehavoir(IFlyBehavior behavior)
        {
            FlyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            QuackBehavior = behavior;
        }

        public abstract void Display();
    }
}
