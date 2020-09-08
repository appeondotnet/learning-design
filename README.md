# learning-design  

Head First 设计模式学习笔记  
1 [Strategy (策略模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Strategy)  
2 [Observer (观察者模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Observer)  
3 [Decorator (装饰者模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Decorator)  
4 [Factory Method (工厂方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/FactoryMethod)  
5 [Singleton Pattern (单例模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/SingletonPattern)  
6 [Command Pattern (命令模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CommandPattern)  
7 [Adapter Pattern (适配器模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/AdapterPattern)  
8 [Facade Pattern (外观模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/FacadePattern)  
9 [TemplateMethod Pattern (模板方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/TemplateMethodPattern)  
10 [ITerator Pattern (迭代器方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/ITeratorPattern)  
11 [Composite Pattern (组合方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CompositePattern)    
  
# OO基础  
1 封装  
2 继承  
3 抽象  
4 多态  

# OO原则  
1 封装变化  
2 针对接口编程， 不针对实现编程  
3 多用组合， 少用继承  
4 为实现松耦合设计而努力  
5 对扩展开放， 对修改关闭  
6 依赖倒置，高层组件不依赖低层组件，高层或者低层组件不依赖具体实现，而是依赖抽象。  
7 最少知道原则，和直接朋友交流  
8 好莱坞原则，高层模块会在需要的时候调用低层模块，而不是让低层模块调用  
9 单一职责原则，对类的修改有且仅有一个类  

# 1 [Strategy (策略模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Strategy)  
策略模式定义了算法族，对各个算法进行了封装，让它们可以相互交换，使算法的改变独立于调用的用户  
# 2 [Observer (观察者模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Observer)  
观察者模式定义了一对多的对象依赖关系，这样一来，如果一个对象的状态发生改变，其它依赖的对象就会得到  
通知并且自动更新。  
# 3 [Decorator (装饰者模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/Decorator)  
装饰者模式定义了动态的将责任添加到对象，相对于继承，装饰者模式提供了更易于扩展的方式。  
# 4 [Factory Method (工厂方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/FactoryMethod)  
工厂方法定义了一个创建对象的接口，让子类决定创建具体的类型，这样就把类的创建推迟到子类。  
抽象工厂定义了一组创建对象的接口，用于创建相关或依赖对象的家族，这样在创建对象的时候不需要指定具体类型。
# 5 [Singleton Pattern (单例模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/SingletonPattern)  
单例模式确保一个类只有一个实例，并且提供一个全局访问点。  
# 6 [Command Pattern (命令模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CommandPattern)  
命令模式把请求封装成对象，这样可以让不同的请求，队列或者日志请求来参数化其它对象，还支持撤销操作。  
# 7 [Adapter Pattern (适配器模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CommandPattern)  
适配器模式将一个类的接口，转换其接口让其适应客户的接口，在不改变类的情况下，让原则不相容的两个类可以合作无间。
# 8 [Facade Pattern (外观模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CommandPattern)    
 外观模式提供了一个统一接口，用于访问子系统的一群接口，外观模式定义了一个高层接口，让子系统更加容易使用。
# 9 [TemplateMethod Pattern (模板方法)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/TemplateMethodPattern)  
模板方法定义了一个方法提供算法的骨架，让算法的一个步骤或者多个步骤延迟到子类，模板方法让子类不改变算法结构的情况下去实现其中的一些步骤。  
# 10 [Iterator Pattern (迭代器模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/IteratorPattern)  
迭代器模式提供了顺序访问聚合对象的元素的方法，而不用暴露其数据结构.  
# 11 [Composite Pattern (组合模式)](https://github.com/appeondotnet/learning-design/tree/zhuxiaoxiong/Src/Design/CompositePattern)     
组合模式允许你将对象组成树形结构来表现"整体与部分"的层次结构，组合模式让客户以一致的方式处理个别对象和组合对象。


