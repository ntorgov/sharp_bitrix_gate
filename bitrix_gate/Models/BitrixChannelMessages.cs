using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace bitrix_gate.Models
{
	class BitrixChannelMessages
	{
		/// <summary>
		/// ID чата
		/// </summary>
		[JsonPropertyName("chat_id")]
		public string ChatId { get; set; }


		/// <summary>
		/// Сообщения в канале
		/// </summary>
		[JsonPropertyName("messages")]
		public BitrixMessage[] Messages { get; set; }


		/// <summary>
		/// Пользователи в канале
		/// </summary>
		[JsonPropertyName("users")]
		public BitrixUser[] Users { get; set; }
	}
}
