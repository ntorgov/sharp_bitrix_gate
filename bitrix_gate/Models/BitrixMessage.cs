using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace bitrix_gate.Models
{
	class BitrixMessage
	{
		/// <summary>
		/// ID сообщения
		/// </summary>
		[JsonPropertyName("id")]
		public long Id { get; set; }

		/// <summary>
		/// ID чата
		/// </summary>
		[JsonPropertyName("chat_id")]
		public string ChatId { get; set; }

		/// <summary>
		/// ID автора
		/// </summary>
		[JsonPropertyName("author_id")]
		public string AuthorId { get; set; }

		/// <summary>
		/// Дата
		/// </summary>
		[JsonPropertyName("date")]
		public string Date { get; set; }

		/// <summary>
		/// Сообщение
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; }

		/// <summary>
		/// Флаг прочтения
		/// </summary>
		[JsonPropertyName("unread")]
		public bool Unread { get; set; }
	}
}
