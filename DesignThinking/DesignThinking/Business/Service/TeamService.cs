using System;
using System.Collections.Generic;
using DesignThinking.Business.Repository;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Service
{
    public class TeamService : ITeamService
    {
        private ITeamRepository teamRepository;
        public TeamService()
        {
            teamRepository = new TeamRepository();
        }

        public bool Delete(Team model) => teamRepository.Delete(model);

        public Team Get(int key) => teamRepository.Get(key);

        public IEnumerable<Team> GetAll() => teamRepository.GetAll();

        public bool Save(Team model) => teamRepository.Save(model);

        public bool Update(Team model, int key) => teamRepository.Update(model, key);
    }
}
