## 建造者模式（Builder）
### 建造者模式也叫生成器模式。
建造者模式（Builder Pattern）使用多个简单的对象一步一步构建成一个复杂的对象。这种类型的设计模式属于创建型模式，它提供了一种创建对象的最佳方式。

一个 Builder 类会一步一步构造最终的对象。该 Builder 类是独立于其他对象的。
建造者模式可以将一个产品的内部表象与产品的生成过程分割开来，从而可以使一个建造过程生成具有不同的内部表象的产品对象。

建造者模式是在当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装配方式时适用的模式。 

## 适配器模式（Adapter Pattern）
适配器模式（Adapter Pattern）是作为两个不兼容的接口之间的桥梁。这种类型的设计模式属于结构型模式，它结合了两个独立接口的功能。

这种模式涉及到一个单一的类，该类负责加入独立的或不兼容的接口功能。
意图：将一个类的接口转换成客户希望的另外一个接口。适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。

主要解决：主要解决在软件系统中，常常要将一些"现存的对象"放到新的环境中，而新环境要求的接口是现对象不能满足的。

## 外观模式（Facade Pattern）
隐藏系统的复杂性，并向客户端提供了一个客户端可以访问系统的接口。这种类型的设计模式属于结构型模式，它向现有的系统添加一个接口，来隐藏系统的复杂性。

这种模式涉及到一个单一的类，该类提供了客户端请求的简化方法和对现有系统类方法的委托调用。
意图：为子系统中的一组接口提供一个一致的界面，外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。

主要解决：降低访问复杂系统的内部子系统时的复杂度，简化客户端与之的接口。

## 模板方法模式（Template Method Pattern）
一个抽象类公开定义了执行它的方法的方式/模板。它的子类可以按需要重写方法实现，但调用将以抽象类中定义的方式进行。这种类型的设计模式属于行为型模式。
意图：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。

主要解决：一些方法通用，却在每一个子类都重新写了这一方法。
## 目录
[建造者模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/BuilderPattern)

[适配器模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/Adapter)

[外观模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/Facade)

[模板方法模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/TemplateMethod)

[迭代器模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/Iterator)

[组合模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/Composite)

[状态模式](https://github.com/appeondotnet/learning-design/tree/zhangguangjian/src/State)

