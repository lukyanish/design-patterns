namespace design_patterns.creational.abstract_factory;

public delegate void Func();

public interface IButton
{
    string Render();
    void OnClick(Func action);
}