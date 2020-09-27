# learning-design
Head First 设计模式学习笔记

# 设计原则
1.开闭原则：对扩展开放，对修改关闭。在程序需要进行拓展的时候，不能去修改原有的代码，实现一个热插拔的效果。所以一句话概括就是：为了使程序的扩展性好，易于维护和升级。想要达到这样的效果，我们需要使用接口和抽象类。  

2.里氏替换原则：任何基类可以出现的地方，子类一定可以出现。是继承复用的基石，只有当衍生类可以替换掉基类，软件单位的功能不受到影响时，基类才能真正被复用，而衍生类也能够在基类的基础上增加新的行为。是对“开闭”原则的补充，实现“开闭”原则的关键步骤就是抽象化。而基类与子类的继承关系就是抽象化的具体实现。  

3.单一职责原则：应该有且只有一个原因引起类的改变，即一个类只负责一个职责。  

4.依赖倒置原则：这个是开闭原则的基础，针对接口编程，依赖于抽象而不依赖于具体。  

5.接口隔离原则：使用多个隔离的接口，比使用单个接口要好。还是一个降低类之间的耦合度的意思。  

6.迪米特法则：最少知道原则，一个实体应当尽量少的与其他实体之间发生相互作用，使得系统功能模块相对独立。  

7.合成复用原则：尽量使用对象组合/聚合, 而不是继承关系达到软件复用的目的。  

# 目录
[策略模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Strategy)  
[观察者模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Observer)  
[装饰者模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Decorator)  
[工厂模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Factory)  
[单例模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Singleton)  
[命令模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Command)  
[适配器模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Adapter)  
[外观模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Facade)  
[模板方法模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/TemplateMethod)  
[迭代器模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Iterator)  
[组合模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Composite)  
[状态模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/State)  
[代理模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Proxy)  
[中介者模式](https://github.com/appeondotnet/learning-design/tree/daijun/DesignPattern/Mediator)  
