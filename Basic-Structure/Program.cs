using Impart;

class Program
{
    public static void Main()
    {
        WebSite webSite = new WebSite(new BasicStructure());
        webSite.Start();
    }
}
class BasicStructure : WebPage
{
    public BasicStructure() : base()
    {
        string link = "https://github.com/PixelatedLagg/Impart";
        
        //Make and decorate Division
        Division d = new Division();
        d.AddText("List of cool projects:");
        d.Attrs.Add(AttrType.Border, new BorderArgs(BorderType.Normal, 3, Rgb.Blue));
        d.Attrs.Add(AttrType.Margin, 15);

        //Make and decorate Text
        Text t = new Text("Where are my pictures of spiderman?");
        t.Attrs.Add(new Attr(AttrType.ForegroundColor, Rgb.Red));
        t.Attrs.Add(new Attr(AttrType.BackgroundColor, Rgb.Black));

        //Add IElements to the WebPage
        Add(new Text("Hello World!", TextType.Bold));
        Add(d);
        Add(new EList<Link>(EListType.Ordered, new Link("Impart", link), new Link("DSharpPlus", link), new Link("Avalonia", link), new Link("Newtonsoft.Json", link))); //Direct everyone to Impart >:)
        Add(t);
        Add(new Image("https://dsharpplus.github.io/images/faq_03.png"));
    }
}