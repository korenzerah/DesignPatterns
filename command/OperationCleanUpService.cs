using System.Collections.Generic;

namespace DesignPatterns.command
{
    public class OperationCleanUpService
    {
        public List<OperationInvoker> invokers {get; set; } = new List<OperationInvoker>();

        public List<OperationInvoker> getCleanUpInvokers() {
            return this.invokers;
        }

        public void batchExecute() {
            this.invokers.ForEach(x => x.Execute());
        }
    }
}