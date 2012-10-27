﻿using Windows.UI.Xaml;

namespace Bobasoft.Presentation.Interactivity
{
	public interface IAttachedObject
	{
		/// <summary>
		/// Gets the associated object.
		/// </summary>
		DependencyObject AssociatedObject { get; }

		/// <summary>
		/// Attaches to the specified object
		/// </summary>
		/// <param name="dependencyObject">The object to attach to.</param>
		void Attach(DependencyObject dependencyObject);

		/// <summary>
		/// Detaches this instance from its associated object.
		/// </summary>
		void Detach();
	}
}