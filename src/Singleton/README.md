# 单例模式
确保一个类只有一个实例，并提供一个全局访问点。

## 为什么需要单例
例如，写日志时，不希望有很多地方都在操作日志文件，以免引起文件占用问题，等等。

## 为什么不用全局变量
有的对象可能会比较耗资源，如果在程序一开始就初始化，可能整个程序运行过程中都不会使用到，造成资源浪费。

## 怎么处理并发问题
* [利用类静态构造函数](https://github.com/appeondotnet/learning-design/blob/9fc01f327929aaffa145f26749f50e4ff711e47b/src/Singleton/Choc-O-Holic/ChocolateBoiler.cs#L5)

* [同步方法](https://github.com/appeondotnet/learning-design/blob/721aae3043f666cc9e0e9fda00683abefe627e6a/src/Singleton/Choc-O-Holic/ChocolateBoiler1.cs#L13)

* 加锁，一般分为
[懒汉式](https://github.com/appeondotnet/learning-design/blob/721aae3043f666cc9e0e9fda00683abefe627e6a/src/Singleton/Choc-O-Holic/ChocolateBoiler2.cs#L14)
和
[双检锁](https://github.com/appeondotnet/learning-design/blob/721aae3043f666cc9e0e9fda00683abefe627e6a/src/Singleton/Choc-O-Holic/ChocolateBoiler3.cs#L14)
，通常推荐使用双检索，降低加锁带来的性能损耗。

## 其他
其实有的软件只能运行一个实例，也能算是一种单例。
