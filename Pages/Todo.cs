namespace BlazorApp1.Pages;

public class Todo
{
    // IsNullOrWhiteSpace ile kontrol ediliyor veri null olmayacağını belirtmek istedim

    //  /... = null!; ile yapmıştım ilk başta lakin sonra string? kısaltmasını kullandım
    public string? Task { get; set; }

    // Direkt false gelsin istemiştim lakin bool değer default false getirdiği için gri yanıyor.
    public bool IsDone { get; set; } = false;
}