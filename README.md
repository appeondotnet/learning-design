# 单例模式
使用场景：在项目中只需要实现一次的类，并且其他类都使用的时候都需要获取到这个类的同一个实例。  
例如语法服务器开启的时候需要初始化启动，之后在其他地方使用需要直接拿到这个已初始化的实例，而不能再次实例化一个新的实例。  

总结：确保一个类只有一个实例，并且提供全局访问。  

# 抽象工厂模式
使用场景：系列化类型变化，而具体产品不变化的情况，例如案例中的游戏资源生成器。  
目前已有两种系列分别为：古典和现代。四种资源组件：建筑、隧道、草丛、道路。  
在这种情况下，如果需要增加一个新的系列“未来”，则只需要增加一个FutureFactory，然后继承FacilitiesFactory实现，在具体化实现未来系列的资源组件，而不会对其他系列产生任何影响。  

不适用场景：在本案例中，如果要增加一种资源组件，则整个项目都受到改动，需要新增资源接口，然后在抽象工厂需要定义，在具体工厂需要实现，并且需要新增加资源实例。  

总结：适合于系列或者风格变动的项目，但是具体的组件或者产品数量不发生改变的场景。  

# 命令模式
概述:将请求封装成对象，可以让使用者使用不同的请求、队列、或者日志来参数化其他对象，并且命令模式可以支持撤销操作。  

要点：  
1.命令模式将发出请求的对象和执行请求的对象解耦。  
2.在被解耦得到两者之间是通过命令对象进行沟通的，命令对象封装了接收者和一个或者一组动作。  
3.调用者通过调用命令对象的Execute()发出请求，这会使得接收者的动作被调用。  
4.调用者可以接受命令当做参数，甚至在运行时动态地进行。  
5.命令可以支持撤销，做法是实现一个Undo()方法来回到Execute()被执行前的状态。  
6.宏命令是命令的一种简单延伸，允许调用多个命令。宏方法也可以支持撤销。  
7.实际操作时，很常见使用“聪明”命令对象，他就是直接实现了请求，而不是将工作委托给了接收者。  
8.命令也可以用来实现日志和事务系统。  

# 适配器模式&外观模式
适配器模式：通过建立一个适配器的类来继承目标接口，然后在适配器中实现需要被适配的对象实例，在接口方法中调用被适配对象的对应方法，达到一个适配器的效果。 
外观模式：提供了一个统一的接口，用来访问子系统中的一群接口。外观定义了一个高层接口，让子系统更容易使用。

要点：  
1.当需要使用一个现有的类而其接口并不符合你的需要时，就使用适配器。  
2.当需要简化并且统一一个很大得到接口或者一群复杂的接口时，使用外观。  
3.适配器改变接口以符合客户的期望。  
4.外观将客户从一个复杂的子系统中解耦。  
5.实现一个适配器，可能需要一番功夫，也可能不费工夫，根据目标接口的大小和复杂度而定。  
6.实现一个外观，需要将子系统组合进外观中，然后将工作委托给子系统执行。  
7.适配器有两种形式：对象适配器和类适配器，类适配器需要用到多重继承。  
8.你可以为一个子系统实现一个以上的外观。  
9.适配器将一个对象包装起来以改变其接口；装饰者将一个对象包装起来以增加新的行为和责任；而外观将一群对象“包装”起来以简化其接口。  

# 模板方法模式  
使用场景：在一些流程固定的情景下，但是某些步骤需要实现的算法可能需要改变，可以使用模板方法模式，规定固定的模板，并且将需要变化的方法声明为抽象，通过子类对模板进行算法的覆写操作，同时还能定义Hook通过子类判定是否需要实现某些算法。  

要点：  
1.“模板方法”定义算法的步骤，把这些步骤的实现延迟到子类。  
2.模板方法模式为我们提供了一种代码复用的重要技巧。  
3.模板方法的抽象类可以定义具体方法、抽象方法和钩子。(abstract,virtual)  
4.抽象方法由子类实现。  
5.钩子是方法的一种，他在抽象中不做事，或者只做默认的事情，子类可以选择要不要去覆盖它。  
6.好莱坞原则告诉我们，将决策权放在高层模块中，以便决定如何以及何时调用底层模块。  
7.你将在真实世界代码中看到模板方法模式的需要变体，所以不要期待能够一眼就能认出他们。  
8.策略模式和模板方法都采用了封装算法，一个用组合，一个用继承。  
9.工厂方法是模板方法的一种特殊版本。

# 迭代器模式  
使用场景:应对各种需要循环遍历的对象，并且对象之间存放的容器有差异，无法通过一个循环解决遍历问题.通过建立一个迭代器的接口，各类需要循环的对象继承该接口，在接口方法中根据自身对象的实际情况编写获取对象算法。在实际使用中只需要通过统一接口的方法取数据即可。  
  
要点:  
1.迭代器允许访问聚合的元素，而不需要暴露他的内部结构。  
2.迭代器将遍历聚合的工作封装进一个对象中。  
3.当使用迭代器的时候，我们依赖聚合提供遍历。  
4.迭代器提供了一个通用的接口，让我们编码使用聚合的项时，就可以使用多态的机制。  
5.我们应该努力让一个类分配一个职责。


# 组合模式  
使用场景:当业务中存在一个对象和该对象的集合处于同一层次的时候，可以通过组合模式将其视为同一类型的对象，通过继承同一个抽象类，各自实现自己的特性，在调用的时候就无须关系是具体的对象还是对象的集合。  

要点:  
1.组合模式提供一个结构，可以同时包容个别对象和组合对象。  
2.组合模式允许客户对个别对象以及组合对象一视同仁。  
3.组合结构内的任意对象称为组件，组件可以是组合也可以是叶节点。  
4.在实现组合模式时，有许多设计上的折衷，要根据需要的平衡透明性和安全性。

# 状态模式
使用场景:1、行为随状态改变而改变的场景。 2、条件、分支语句的代替者。 
优点:  
1、封装了转换规则。 
2、枚举可能的状态，在枚举状态之前需要确定状态种类。  
3、将所有与某个状态有关的行为放到一个类中，并且可以方便地增加新的状态，只需要改变对象状态即可改变对象的行为。  
4、允许状态转换逻辑与状态对象合成一体，而不是某一个巨大的条件语句块。 5、可以让多个环境对象共享一个状态对象，从而减少系统中对象的个数。  

缺点：  
1、状态模式的使用必然会增加系统类和对象的个数。  
2、状态模式的结构与实现都较为复杂，如果使用不当将导致程序结构和代码的混乱。  
3、状态模式对"开闭原则"的支持并不太好，对于可以切换状态的状态模式，增加新的状态类需要修改那些负责状态转换的源代码，否则无法切换到新增状态，而且修改某个状态类的行为也需修改对应类的源代码。 

总结:通常命令模式的接口中只有一个方法。而状态模式的接口中有一个或者多个方法。而且，状态模式的实现类的方法，一般返回值，或者是改变实例变量的值。也就是说，状态模式一般和对象的状态有关。实现类的方法有不同的功能，覆盖接口中的方法。状态模式和命令模式一样，也可以用于消除 if...else 等条件选择语句。  

# 设计原则
1.封装变化。  
2.多用组合，少用继承。  
3.针对接口编程，不针对实现编程。  
4.为交互对象之间的松耦合设计而努力。  
5.类应该对扩展开放，对修改关闭。  
6.依赖抽象，而不依赖具体实现。  
7.最少知道原则：只和你的密友谈话。(迪米特法则)


## 目录
[单例模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/SingletonPattern)  
[抽象工厂模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/AbstractFactoryPattern)  
[适配器&外观模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/AdapterPattern)  
[建造者模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/BuilderPattern)  
[命令模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/CommendPattern)  
[模板方法模式](https://github.com/appeondotnet/learning-design/tree/pengsongkun/TemplateMethodPattern)  
