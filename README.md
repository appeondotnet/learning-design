# learning-design
Head First 设计模式学习笔记。

## 目录
[策略模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Strategy)  
[观察者模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Observer)  
[装饰者模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Decorator)  
[工厂模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Factory)  
[单例模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Singleton)  
[命令模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Command)  
[适配器模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Adapter)  
[外观模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Facade)  
[模板方法模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Template)  
[迭代器模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Iterator)  
[组合模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Composite)  

## 精神
* 系统中某部分改变不会影响其他部分
* 使用共享词汇能让更少的词汇做更充分的沟通
* 把注意力放在设计中最有可能改变的地方，而不是每个地方

## 原则
* 封装变化。
    - 找出应用中可能需要变化之处，把他们独立出来，不要和那些不需要变化得代码混在一起；
    - 即：把会变化的部分提出并封装起来，以便以后可以轻易地改动或扩充此部分，而不影响不需要变动的部分。
* 多用组合，少用继承。
* 针对接口编程，而不是针对实现编程。
* 为了交互对象之间的松耦合设计而努力。
* 开放关闭原则
    - 类应该对扩展开放，对修改关闭；
    - 即：允许系统在不修改代码的情况下，对功能扩展；通过提供扩展的方法来保护代码代码免于被修改。
* 要依赖抽象，不要依赖具体类
* 最少知道原则：不要让太多的类耦合在一起，以免修改系统中一部分，会影响到其他部分。
* 别调用我，我会调用你：由超类主控一切，当他们需要的时候自然回去调用子类。
* 单一职责：一个类应该之哟一个引起变化的原因

## 定理
### Change
> 不管当初软件设计得有多好，一段时间后，总是需要成长与改变，否则软件就会“死亡”。

### 最少知道原则
在任何对象的方法内，调用的范围：
- 该对象本身
- 被当作方法参数而传递的对象
- 此方法所创建或者实例化的任何对象
- 该对象的任何成员

## 内聚
当一个模块或一个类被设计成只支持一组相关功能时，我们说它具有高内聚，反之，当被设计成支持一组不相关的功能时，我们说它具有低内聚。