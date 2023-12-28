namespace design_patterns.creational.abstract_factory;


/*
 * Фабричный метод - порождающий паттерн проектирования, который
 * определяет общий интерфейс для создания объектов в суперклассе,
 * позволяя подклассам изменять тип создаваемых объектов.
 * 
 *
 * Проблема:
 * Код приложения написан для работы с определенными объектами класса,
 * когда появляется потребность в добавлении функциональности
 * работы с объектами других классов - приходится перелопачивать всю
 * кодовую базу на if-ки, или что похуже.
 *
 * 
 * Решение:
 * Паттерн предлагает создавать объекты не напрямую через оператор new,
 * а через вызов особого фабричного метода.Объекты все равно будут
 * создаваться при помощи new, но делать это будет фабричный метод.
 */

public class AbstractFactory
{
    private Dialog? _dialog;

    private void Initialize()
    {
        // Or "Web"
        const string os = "Windows";

        _dialog = os switch
        {
            "Windows" => new WindowsDialog(),
            "Web" => new HtmlDialog(),
            _ => throw new System.Exception("Error! Unknown operating system.")
        };
    }

    public void Run()
    {
        this.Initialize();
        _dialog?.Render();
    }
}