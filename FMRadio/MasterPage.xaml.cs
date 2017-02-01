using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FMRadio
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Top Stations",
				IconSource = "contacts.png",
				TargetType = typeof(TopStationsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "TodoList",
				IconSource = "todo.png",
				TargetType = typeof(TodoListPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Reminders",
				IconSource = "reminders.png",
				TargetType = typeof(ReminderPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
