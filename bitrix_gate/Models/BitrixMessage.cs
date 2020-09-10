using System;
using System.Collections.Generic;
using System.Text;

namespace bitrix_gate.Models
{
	class BitrixMessage
	{
		/// <summary>
		/// ID сообщения
		/// </summary>
		public long id { get; set; }

		/// <summary>
		/// ID чата
		/// </summary>
		public string chat_id { get; set; }

		/// <summary>
		/// ID автора
		/// </summary>
		public string author_id { get; set; }

		/// <summary>
		/// Дата
		/// </summary>
		public string date { get; set; }

		/// <summary>
		/// Сообщение
		/// </summary>
		public string text { get; set; }

		/// <summary>
		/// Флаг прочтения
		/// </summary>
		public bool unread { get; set; }
	}
}
