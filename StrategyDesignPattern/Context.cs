namespace StrategyDesignPattern
{
    public class Context
    {
        private Strategy m_strategy;

        public Context(Strategy strategy)
        {
            m_strategy = strategy;
        }

        public void ImplementAlgorithm()
        {
            if(m_strategy != null)
                m_strategy.Algorithm();
        }
    }
}