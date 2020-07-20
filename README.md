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

# 策略模式
找出应用中可能需要变化之处，把它们独立出来，不要和那些不需要变化的代码混在一起。  

把会变化的部分取出来并封装起来，以便以后可以轻易的改动或此部分，而不影响不需要变化的其他部分。  

定义一系列的算法，把他们一个个封装起来，并使他们可以互相替换，本模式使得算法可以独立于使用它们的客户。  

# 观察者模式
又叫发布-订阅模式（Publish/Subscribe）  
定义对象间一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知自动更新。  

优点：观察者和被观察者是抽象耦合的，建立了一套触发机制。  

缺点：如果一个被观察者对象有很多的直接和间接的观察者的话，将所有的观察者都通知到会花费很多时间。  

应用场景： 某个实例的变化将影响其他多个对象。  

# 装饰者模式
在不改变原有对象的基础之上，将功能附加到对象上。提供了比继承更有弹性的替代方案（扩展原有对象功能）。  

优点：  
1.继承的有力补充，比继承灵活，不改变原有对象的情况下给一个对象扩展功能。（继承在扩展功能是静态的，必须在编译时就确定好，而使用装饰者可以在运行时决定，装饰者也建立在继承的基础之上的）。  
2.通过使用不同装饰类以及这些类的排列组合，可以实现不同的效果。  

缺点：会出现更多的代码，更多的类，增加程序的复杂性。  

应用场景：  
1.扩展一个类的功能或者给一个类添加附加职责。  
2.给一个对象动态的添加功能，或动态撤销功能。  

# 工厂模式
定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个，工厂方法让类把实例化推迟到子类。该模式用于封装和管理对象的创建，是一种创建型模式。  

主要解决：接口选择的问题。  

何时使用：我们明确地计划不同条件下创建不同实例时。  

如何解决：让其子类实现工厂接口，返回的也是一个抽象的产品。  

缺点：很难支持新种类产品的变化。这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了开发封闭原则。  