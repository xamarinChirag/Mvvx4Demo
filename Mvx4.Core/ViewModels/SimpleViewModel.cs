using MvvmCross.Core.ViewModels;
using Sequence.Plugins.InfiniteScroll;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Mvx4.Core.ViewModels
{
    public class SimpleViewModel : MvxViewModel
    {

        private readonly IIncrementalCollectionFactory _incrementalCollectionFactory;
        private readonly int _numberListPageSize = 30;
        private ObservableCollection<NumberViewModel> _numbers;


        public SimpleViewModel(IIncrementalCollectionFactory incrementalCollectionFactory)
        {
            _incrementalCollectionFactory = incrementalCollectionFactory;
        }

        public ObservableCollection<NumberViewModel> Numbers
        {
            get
            {
                if (_numbers == null)
                {
                    // The IncrementalCollectionFactory returns a generic ObservableCollection. In this example, 
                    // it returns ObservableCollection<NumberViewModel>. Replace this with your own ViewModel.

                    _numbers = _incrementalCollectionFactory.GetCollection(async (count, pageSize) =>
                    {
                        ObservableCollection<NumberViewModel> newNumbers = new ObservableCollection<NumberViewModel>();

                        // Call an async method here to load the data from a data source that supports paging.
                        // This is a dummy implementaion.

                        await Task.Run(() =>
                        {
                            for (int n = count; n < (count + pageSize); n++)
                            {
                                NumberViewModel numberViewModel = new NumberViewModel();
                                numberViewModel.Value = n;
                                newNumbers.Add(numberViewModel);
                            }
                        });

                        return newNumbers;
                    }, _numberListPageSize);
                }

                return _numbers;
            }
        }
    }
}