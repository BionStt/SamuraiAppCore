﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using SamuraiAppCore.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SamuraiAppCore.Data
{
    public class ConnectedData
    {
        private SamuraiContext _context;

        public ConnectedData()
        {
            _context = new SamuraiContext();
            _context.Database.EnsureCreated();
        }

        public Samurai CreateNewSamurai()
        {
            // TODO
            throw new NotImplementedException();
        }

        public ObservableCollection<Samurai> SamuraisListInMemory()
        {
            if (_context.Samurais.Local.Count == 0)
            {
                _context.Samurais.ToList();
            }
            return _context.Samurais.Local.ToObservableCollection(); //TODO check this statement
        }

        public Samurai LoadSamuraiGraph(int samuraiId)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void SaveChanges(Type typeBeingEdited)
        {
            // TODO
            throw new NotImplementedException();
        }

        public LocalView<Battle> BattlesListInMemory()
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> SamuraisNotInBattle(int battleId)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Battle LoadBattleGraph(int battleId)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void AddSamuraiBattle(SamuraiBattle samuraiBattle)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void RevertBattleChanges(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Battle CreateNewBattle()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
