local unpack = unpack or table.unpack

local generator_mt = {
    __index = {
        MoveNext = function(self)
            self.Current = self.co()
            if self.Current == move_end then
                self.Current = nil
                return false
            else
                return true
            end
        end;
        Reset = function(self)
            self.co = coroutine.wrap(self.w_func)
        end
    }
}

local function cs_generator(func, ...)
    local params = {...}
    local generator = setmetatable({
        w_func = function()
            func(unpack(params))
            return move_end
        end
    }, generator_mt)
    generator:Reset()
    return generator
end

return {
    start = function(mono_behaviour, ...)
	    return mono_behaviour:StartCoroutine(cs_generator(...))
	end;

	stop = function(mono_behaviour, coroutine)
	   mono_behaviour:StopCoroutine(coroutine)
	end
}