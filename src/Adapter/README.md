# 适配器模式
将一个类的接口，转换成客户期望的另一个接口。适配器让原本接口不兼容的类可以合作无间。

## 基本点
- 不用改动旧的类，便可以应用到新的接口；
- 封装了变化，将所有需要改动的代码全部封装到适配器中，并且当接口有改动时，也仅仅需要改动适配器即可；
- 使用的是组合，所有任何子类都可以使用该适配器

## 与装饰者
适配器会进行接口转换，而装饰者只是添加新的责任，不会进行接口转换。

```csharp
class Program
{
    static void Main(string[] args)
    {
        Stream stream = File.OpenRead("text.txt");

        stream = new GZipStream(stream, CompressionMode.Decompress);

        AdapteInvoke(stream);
    }

    static void AdapteInvoke(Stream stream)
    {
        var reader = new StreamReader(stream);

        Adapte(reader);
    }

    static void Adapte(TextReader reader)
    {
    }
}
```