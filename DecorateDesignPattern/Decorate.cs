namespace DecorateDesignPattern
{
    public abstract class Decorate : Component
    {
        private Component m_component;
        public void SetComponent(Component component)
        {
            m_component = component;
        }

        public override void Operation()
        {
            if (m_component != null)
                m_component.Operation();
        }
    }
}