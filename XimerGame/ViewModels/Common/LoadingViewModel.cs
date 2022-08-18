﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using XimerGame.Shared.Helpers;
using XimerGame.Shared.Helpers.Abstract;
using XimerGame.Shared.Validators;

namespace XimerGame.ViewModels.Common;

public partial class LoadingViewModel : ObservableObject
{
    public LoadingViewModel(IAccountHelper accountHelper, IConfigurationHelper configurationHelper)
    {
        AccountHelper=accountHelper;
        ConfigurationHelper=configurationHelper;
    }

    IAccountHelper AccountHelper { get; set; }

    IConfigurationHelper ConfigurationHelper { get; set; }

    public async Task TryLoginAndNavigateAsync()
    {
        //(string usrn, string psw, bool rempsd, bool autolog) = ConfigurationHelper.LoginForm;
        //var usrn = "";
        //if (!ValidationHelper.TryValidate(typeof(UsernameValidator), out string message, usrn))
        //{
        //    await Shell.Current.DisplayPromptAsync("用户名格式错误", message);
        //    return;
        //}
        await Shell.Current.GoToAsync("LoginPage");//导航至登陆页面并附带信息
    }
}