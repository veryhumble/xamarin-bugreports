using Bugreports.Controls.Cells;
using Bugreports.ViewModels.List;
using Xamarin.Forms;

namespace Bugreports.Mvvm.DataTemplateSelectors
{
    public class GroupHeaderTemplateSelector : DataTemplateSelector
    {
        private readonly DataTemplate _headerEmptyTemplate;
        private readonly DataTemplate _headerTemplate;

        public GroupHeaderTemplateSelector()
        {
            _headerEmptyTemplate = new DataTemplate(typeof(GroupHeaderEmptySpaceCell));
            _headerTemplate = new DataTemplate(typeof(GroupHeaderCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is IHaveGroupHeaderVisibility viewmodel))
            {
                return _headerEmptyTemplate;
            }

            if (viewmodel.HeaderVisible)
            {
                return _headerTemplate;
            }
            return _headerEmptyTemplate;
        }
    }
}