﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDoM.Core
{
    public class Track
    {
        /// <summary>
        /// Number in the album
        /// </summary>
        public int Number;

        /// <summary>
        /// Name of the track
        /// </summary>
        public string Name;

        /// <summary>
        /// Length of the track
        /// </summary>
        public TimeSpan Length;

        /// <summary>
        /// Genre of the song
        /// </summary>
        public string Genre;

        /// <summary>
        /// ID of the track.
        /// </summary>
        public CID ID;

        /// <summary>
        /// ID of the album that the track is in.
        /// </summary>
        public CID AlbumID;

        /// <summary>
        /// ID of the artist.
        /// </summary>
        public CID ArtistID;

        /// <summary>
        /// URI for sources that have the audio for this track.
        /// May be Youtube videos or soundcloud links
        /// </summary>
        public string[] EquivalentSourceURI;

        public Track()
        {

        }
        public Track(int Number, string Name, TimeSpan length, string Genre, CID id, CID AlbumID, CID ArtistID)
        {

        }


        /// <summary>
        /// Gets the name of the artist who made the track.
        /// </summary>
        /// <returns>String with the artist's name. "Unknown Artist" if not found.</returns>
        public string GetArtistName()
        {
            return Aggregator.GetArtist(ArtistID).Name;
        }

    }
}
