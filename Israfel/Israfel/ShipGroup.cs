using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ElectronicObserver.Data;
using Israfel.Annotations;

namespace Israfel
{
	public class ShipGroup : INotifyPropertyChanged
	{
		private readonly List<int> _shipIds;

		private IEnumerable<ShipData> _ships =>
			_shipIds.Select(i => KCDatabase.Instance.Ships[i]).OrderByDescending(s => s.ExpTotal);

		private ShipData _minShip => _ships.Last();
		private ShipData _maxShip => _ships.First();

		public ShipGroup(int groupId, List<int> shipIds)
		{
			GroupId = groupId;
			_shipIds = shipIds;
		}

		public int GroupId { get; }
		public string MaxShip => _maxShip.NameWithLevel;
		public string MinShip => _minShip.NameWithLevel;
		public int DeltaLevel => _maxShip.Level - _minShip.Level;
		public int DeltaExp => _maxShip.ExpTotal - _minShip.ExpTotal;

		public string AllShips => String.Join("\n", _ships.Select(s => $"[{s.ID}] {s.NameWithLevel} ({s.ExpTotal})"));

		public void NotifyChange(HashSet<int> membersToUpdate)
		{
			if (_shipIds.Any(membersToUpdate.Contains))
				OnPropertyChanged();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}