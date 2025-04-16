//  ISearchProvider
//  ----------------------------------------------
//
//  ----------------------------------------------
//  Created: 2018-08-17
//  Created by: Mikael Ekroth (mikael.kl.ekroth@gmail.com)
//
//  Copyright 2018  


using MultiSearch.Library.Models;

namespace MultiSearch.Library.Providers.Interfaces
{
    public interface ISearchProvider
    {
        SearchResult ExecuteSearch(string query);
    }
}
