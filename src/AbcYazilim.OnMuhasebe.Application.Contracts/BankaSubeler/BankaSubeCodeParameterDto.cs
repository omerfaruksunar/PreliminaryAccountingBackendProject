﻿using AbcYazilim.OnMuhasebe.CommonDtos;
using System;
using Volo.Abp.Application.Dtos;

namespace AbcYazilim.OnMuhasebe.BankaSubeler;
public class BankaSubeCodeParameterDto : IDurum, IEntityDto
{
	public Guid BankaId { get; set; }
	public bool Durum { get; set; }
}
