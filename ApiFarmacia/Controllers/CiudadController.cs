using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiFarmacia.Dtos;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiFarmacia.Controllers;


public class CiudadController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CiudadController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CiudadDto>>> Get()
    {
        var entity = await _unitOfWork.Ciudades.GetAllAsync();
        return _mapper.Map<List<CiudadDto>>(entity);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CiudadDto>> Get(int id)
    {
        var entity = await _unitOfWork.Ciudades.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return _mapper.Map<CiudadDto>(entity);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Ciudad>> Post(CiudadDto entityDto)
    {
        var entity = _mapper.Map<Ciudad>(entityDto);
    /*
        if (entity.FechaCreacion == DateTime.MinValue)
        {
            entity.FechaCreacion = DateTime.Now;
            entityDto.FechaCreacion = DateTime.Now;
        }
        if (entity.FechaModificacion == DateTime.MinValue)
        {
            entity.FechaModificacion = DateTime.Now;
            entityDto.FechaModificacion = DateTime.Now;
        }
    */
        _unitOfWork.Ciudades.Add(entity);
        await _unitOfWork.SaveAsync();
        if (entity == null)
        {
            return BadRequest();
        }
        entityDto.Id = entity.Id;
        return CreatedAtAction(nameof(Post), new { id = entityDto.Id }, entityDto);
    }   
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CiudadDto>> Put(int id, [FromBody] CiudadDto entityDto)
    {
        var entity = _mapper.Map<Ciudad>(entityDto);
        if (entity.Id == 0)
        {
            entity.Id = id;
        }
        if (entity.Id != id)
        {
            return BadRequest();
        }
        if (entity == null)
        {
            return NotFound();
        }
    /*
        if (entity.FechaCreacion == DateTime.MinValue)
        {
            entity.FechaCreacion = DateTime.Now;
            entityDto.FechaCreacion = DateTime.Now;
        }
        if (entity.FechaModificacion == DateTime.MinValue)
        {
            entity.FechaModificacion = DateTime.Now;
            entityDto.FechaModificacion = DateTime.Now;
        }
    */
        entityDto.Id = entity.Id;
        _unitOfWork.Ciudades.Update(entity);
        await _unitOfWork.SaveAsync();
        return entityDto;
    }
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(int id)
    {
        var entity = await _unitOfWork.Ciudades.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        _unitOfWork.Ciudades.Remove(entity);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
