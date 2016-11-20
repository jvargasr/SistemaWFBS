﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterPages.Master
{
	public class Master : Control
	{
		static Master()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Master), new FrameworkPropertyMetadata(typeof(Master)));
		}

        public object UserInfo
        {
            get { return (object)GetValue(UserInfoProperty); }
            set { SetValue(UserInfoProperty, value); }
        }

        public static readonly DependencyProperty UserInfoProperty =
            DependencyProperty.Register("UserInfo", typeof(object), typeof(Master), new UIPropertyMetadata());


        public object Title
		{
			get { return (object)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		public static readonly DependencyProperty TitleProperty =
			DependencyProperty.Register("Title", typeof(object), typeof(Master), new UIPropertyMetadata());

		public object Abstract
		{
			get { return (object)GetValue(AbstractProperty); }
			set { SetValue(AbstractProperty, value); }
		}

		public static readonly DependencyProperty AbstractProperty =
			DependencyProperty.Register("Abstract", typeof(object), typeof(Master), new UIPropertyMetadata());

		public object Content
		{
			get { return (object)GetValue(ContentProperty); }
			set { SetValue(ContentProperty, value); }
		}

		public static readonly DependencyProperty ContentProperty =
			DependencyProperty.Register("Content", typeof(object), typeof(Master), new UIPropertyMetadata());

        public object Footer
        {
            get { return (object)GetValue(FooterProperty); }
            set { SetValue(FooterProperty, value); }
        }

        public static readonly DependencyProperty FooterProperty =
            DependencyProperty.Register("Footer", typeof(object), typeof(Master), new UIPropertyMetadata());

    }
}
