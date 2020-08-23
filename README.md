# learning-design
Head First 设计模式学习笔记
# 设计原则
1.多用组合少用继承，使用组合建立系统具有很大的弹性，不仅可以将算法封装成类，更可以再运行时动态改变行为，只要组合的行为对象符合正确的接口标准即可。<br/>
2.针对接口编程，而不是针对实现编程。<br/>
3.为交互对象之间的松耦合设计而努力。<br/>
4.类应该对扩展开放，对修改关闭。<br/>
5.依赖抽象，不要依赖具体类。
# 策略模式
定义了算法族,分别封装起来呢，让他们之间可以互相替换，此模式让算法的变化独立于使用算法的客户。

# 观察者模式
在对象之间定义一对多的依赖，这样一来，当一个对象改变状态，依赖他的对象都会收到通知，并自动更新。在观察者模式中，会改变的是主题状态，以及观察者的数目和类型，用这个模式，你可以改变依赖于主题状态的对象，却不必改变主题。

# 装饰者模式
动态的将责任附加到对象上。想要扩展功能，装饰者提供有别于继承的另一种选择。意味着装饰者类来包装具体组件，他们具有相同的类型，都通过接口和继承实现。<br/>
装饰者会导致设计中出现许多小对象，如果过度使用会让程序变得复杂。

# 工厂模式
定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。工厂让类实例化推迟到子类。所有工厂模式都通过减少应用程序和具体类之间的依赖来促进松耦合。
