using EPiServer.Core;

namespace Cms.Core.ViewModel.Base
{
    public class ComposedBlockViewModel<TBLock, TViewModel>
           where TBLock : BlockData
    {
        public TBLock Block { get; set; }

        public TViewModel ViewModel { get; set; }
    }
}
