namespace ResponsibilityDesignPattern
{
    public abstract class Handle
    {
        protected Handle _successor;
        public void SetSuccessor(Handle successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}