# learning-design
Head First 设计模式学习笔记。

## 目录
[策略模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Strategy)  
[观察者模式](https://github.com/appeondotnet/learning-design/tree/dudeping/src/Observer)

## 精神
* 系统中某部分改变不会影响其他部分
* 使用共享词汇能让更少的词汇做更充分的沟通

## 原则
* 封装变化。
    - 找出应用中可能需要变化之处，把他们独立出来，不要和那些不需要变化得代码混在一起；
    - 即：把会变化的部分提出并封装起来，以便以后可以轻易地改动或扩充此部分，而不影响不需要变动的部分。
* 多用组合，少用继承。
* 针对接口编程，而不是针对实现编程。
* 为了交互对象之间的松耦合设计而努力。

## 定理
### Change
> 不管当初软件设计得有多好，一段时间后，总是需要成长与改变，否则软件就会“死亡”。
