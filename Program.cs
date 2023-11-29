namespace Factory
{
    public interface IButton
    {
        public void render();
        public void onClick();
    }

    public class WindowsButton : IButton
    {
        public void onClick()
        {
            //do work
        }

        public void render()
        {
            //do work
        }
    }

    public class HTMLButton : IButton
    {
        public void onClick()
        {
            //do work
        }

        public void render()
        {
            //do work
        }
    }

    public abstract class Dialog
    {
        public IButton? okButton;


        public abstract IButton createButton();

        public void render()
        {
            okButton = createButton();
            okButton.onClick();
            okButton.render();

        }
    }

    public class WindowsDialog : Dialog
    {
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }

    public class WebDialog : Dialog
    {
        public override IButton createButton()
        {
            return new HTMLButton();
        }
    }
}
