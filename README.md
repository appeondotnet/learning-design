# learning-design
Head First 设计模式学习笔记
# 设计原则
1.多用组合少用继承，使用组合建立系统具有很大的弹性，不仅可以将算法封装成类，更可以再运行时动态改变行为，只要组合的行为对象符合正确的接口标准即可。<br/>
2.针对接口编程，而不是针对实现编程。<br/>
3.为交互对象之间的松耦合设计而努力。<br/>
4.类应该对扩展开放，对修改关闭。<br/>
5.依赖抽象，不要依赖具体类。<br/>
6.一个类只有一个引起变化的原因
# 策略模式
定义了算法族,分别封装起来呢，让他们之间可以互相替换，此模式让算法的变化独立于使用算法的客户。

# 观察者模式
在对象之间定义一对多的依赖，这样一来，当一个对象改变状态，依赖他的对象都会收到通知，并自动更新。在观察者模式中，会改变的是主题状态，以及观察者的数目和类型，用这个模式，你可以改变依赖于主题状态的对象，却不必改变主题。

# 装饰者模式
动态的将责任附加到对象上。想要扩展功能，装饰者提供有别于继承的另一种选择。意味着装饰者类来包装具体组件，他们具有相同的类型，都通过接口和继承实现。<br/>
装饰者会导致设计中出现许多小对象，如果过度使用会让程序变得复杂。

# 工厂模式
定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。工厂让类实例化推迟到子类。所有工厂模式都通过减少应用程序和具体类之间的依赖来促进松耦合。

# 迭代器模式
提供一种方法顺序访问一个聚合对象的各个元素，而又不暴露器内部的表示,这样既可以做到不暴露集合的内部结构，又可让外部代码透明地访问集合内部的数据。
迭代器模式是针对集合对象而生的，对于集合对象而言，肯定会涉及到对集合的添加和删除操作，同时也肯定支持遍历集合元素的操作，我们此时可以把遍历操作放在集合对象中，但这样的话，集合对象既承担太多的责任了，面向对象设计原则中有一条就是单一职责原则，所有我们要尽可能地分离这些职责，用不同的类取承担不同的责任，迭代器模式就是用迭代器类来承担遍历集合的职责<Br/>
优点:为遍历不同的集合结构提供了一个统一的接口，从而支持同样的算法在不同的集合结构上进行操作<Br>
缺点：在遍历的同时更改迭代器所在的集合结构会导致出现异常，使用foreach语句只能在对集合进行遍历，不能在遍历的同时更改集合中的元素。

# 组合模式
允许你将对象组成树形结构来表现"整体/部分"的层次结构。组合能让客户一致的方式处理个别对象和对象组合。<br/>
使用场景:<Br>
  1.当想表达对象的部分-整体的层次结构时<br/>
  2.希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象时<br/>
缺点：
  需花时间理清层次关系<br/>
优点：
  无需特殊处理单个对象，当有新组件时容易扩展添加。
