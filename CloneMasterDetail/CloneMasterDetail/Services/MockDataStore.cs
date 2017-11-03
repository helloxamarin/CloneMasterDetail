using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloneMasterDetail.Models;

namespace CloneMasterDetail.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private readonly List<Item> _items;

        public MockDataStore()
        {
            _items = new List<Item>
            {
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "First item",
                    Description = "This is an item description."
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Second item",
                    Description = "This is an item description."
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Third item",
                    Description = "This is an item description."
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Fourth item",
                    Description = "This is an item description."
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Fifth item",
                    Description = "This is an item description."
                },
                new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Text = "Sixth item",
                    Description = "This is an item description."
                },
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var selectdItem = _items.FirstOrDefault(arg => arg.Id == item.Id);
            _items.Remove(selectdItem);
            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var selectdItem = _items.FirstOrDefault(arg => arg.Id == id);
            _items.Remove(selectdItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(_items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}
