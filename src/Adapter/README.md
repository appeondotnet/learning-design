# ������ģʽ
��һ����Ľӿڣ�ת���ɿͻ���������һ���ӿڡ���������ԭ���ӿڲ����ݵ�����Ժ����޼䡣

## ������
- ���øĶ��ɵ��࣬�����Ӧ�õ��µĽӿڣ�
- ��װ�˱仯����������Ҫ�Ķ��Ĵ���ȫ����װ���������У����ҵ��ӿ��иĶ�ʱ��Ҳ������Ҫ�Ķ����������ɣ�
- ʹ�õ�����ϣ������κ����඼����ʹ�ø�������

## ��װ����
����������нӿ�ת������װ����ֻ������µ����Σ�������нӿ�ת����

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