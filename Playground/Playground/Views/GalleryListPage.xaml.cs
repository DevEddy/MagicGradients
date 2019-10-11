﻿using Xamarin.Forms;

namespace Playground.Views
{
    public partial class GalleryListPage : ContentPage
    {
        public GalleryListPage()
        {
            InitializeComponent();
        }

        private void GalleryList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GalleryList.SelectedItem != null)
            {
                GalleryList.SelectedItem = null;
            }
        }
    }
}