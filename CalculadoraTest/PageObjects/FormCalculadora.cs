using Mobilize.QualityMate.Automation.Entities;
using Mobilize.QualityMate.Automation.Selectors;
using Mobilize.QualityMate.ControlInterfaces;

public class FormCalculadora : PageObject
{
    [Selector("#inputNum1")]
    public ITextBox textBox1 { get; set; }

    [Selector("#inputNum2")]
    public ITextBox textBox2 { get; set; }

    [Selector("#inputResultado")]
    public ITextBox textBox3 { get; set; }

    [Selector("#btnCalcular")]
    public IButton button1 { get; set; }
}
