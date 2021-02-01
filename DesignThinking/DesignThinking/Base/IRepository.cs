using System;
using System.Collections.Generic;
using DesignThinking.Models;

namespace DesignThinking.Base
{
    public interface IRepository <Key, Entity>
    {
		/// <summary>
		/// Represents the method to save an entity to a specific data house
		/// </summary>
		/// <param name="model">Represents the model that will be saved</param>
		/// <returns>Returns a bool, true means the entity was saved</returns>
		bool Save(Entity model);

		/// <summary>
		/// Returns a bool where true means the update 
		/// of entity based on a key was succesful
		/// </summary> 
		/// <param name="model"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		bool Update(Entity model, Key key);

		/// <summary>
		/// Returns a bool which indicates either if the delete was succesful
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		bool Delete(Entity model);

		/// <summary>
		/// Returns the entity based on a key
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		Entity Get(Key key);

		/// <summary>
		/// Returns all entities as an ienumerable
		/// </summary>
		/// <returns></returns>
		IEnumerable<Entity> GetAll();
	}
}
